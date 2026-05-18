using lighPayrollUI;
using lightPayrollModel;
using lightPayrollServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lighPayroll
{
    public partial class Chat : Form
    {
        private string user_role, user_name;
        private int user_id;

        private ChatService _chatService;
        private int selectedReceiverId;

        HBorderRadius borderPanel = new HBorderRadius();

        public Chat(string role, string username, int id)
        {
            InitializeComponent();

            user_role = role;
            user_name = username;
            user_id = id;

            _chatService = new ChatService(
                GeneralDataService.LoadConnectionString()
            );
        }

        private void ChatDashboard_Load(object sender, EventArgs e)
        {
            borderPanel.SetRoundedRegion(rightInsidePanel, 33);
            borderPanel.SetRoundedRegion(chatMessagePanel, 33);
            borderPanel.SetRoundedRegion(chatUserAppearancePanel, 33);

            if (user_role == "Admin" || user_role == "Manager")
            {
                var users = _chatService.GetChatUsersForAdmin(user_id);

                foreach (var user in users)
                {
                    AddChatRequest(user.Id, user.Name);
                }
            }
            else
            {
                var admin = _chatService.GetAdminUser();

                if (admin != null)
                {
                    AddChatRequest(admin.Id, admin.Name);
                }
            }
        }

        // =========================
        // ADD USER TO CHAT LIST
        // =========================
        private void AddChatRequest(int receiverId, string username)
        {
            Panel chatItem = new Panel();
            chatItem.Height = 60;
            chatItem.Dock = DockStyle.Top;
            chatItem.BackColor = Color.FromArgb(33, 44, 66);

            // Store BOTH ID and NAME
            chatItem.Tag = new ChatUserTag
            {
                Id = receiverId,
                Name = username
            };

            Label nameLabel = new Label();
            nameLabel.Text = username;
            nameLabel.ForeColor = Color.White;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            nameLabel.Padding = new Padding(10, 0, 0, 0);

            chatItem.Controls.Add(nameLabel);

            chatItem.Click += ChatItem_Click;
            nameLabel.Click += ChatItem_Click;

            chatUserAppearancePanel.Controls.Add(chatItem);
            chatUserAppearancePanel.Controls.SetChildIndex(chatItem, 0);
        }

        // =========================
        // SELECT USER CHAT
        // =========================
        private void ChatItem_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;

            if (ctrl is Label)
                ctrl = ctrl.Parent;

            ChatUserTag data = (ChatUserTag)ctrl.Tag;

            selectedReceiverId = data.Id;

            senderName.Text = data.Name;
            senderName.Visible = true;

            LoadConversation();
        }

        // =========================
        // LOAD CHAT HISTORY
        // =========================
        private void LoadConversation()
        {
            chatMessageAppearancePanel.Controls.Clear();

            var messages = _chatService.GetConversation(
                user_id,
                selectedReceiverId
            );

            foreach (var msg in messages)
            {
                bool isMe = msg.SenderID == user_id;

                AddMessageBubble(msg.Message, isMe);
            }
        }

        // =========================
        // ENTER TO SEND
        // =========================
        private void chatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        // =========================
        // SEND MESSAGE
        // =========================
        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = chatBox.Text.Trim();

            if (string.IsNullOrEmpty(message))
                return;

            if (selectedReceiverId == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            // SAVE TO DATABASE
            _chatService.SaveMessage(new ChatMessage
            {
                SenderID = user_id,
                ReceiverID = selectedReceiverId,
                Message = message,
                SentAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            });

            // SHOW MESSAGE
            AddMessageBubble(message, true);

            chatBox.Clear();
        }

        // =========================
        // CHAT BUBBLE UI
        // =========================
        //chat popped up
        private void AddMessageBubble(string message, bool isRecepient)
        {
            Panel container = new Panel();
            container.Dock = DockStyle.Top;
            container.Height = 60;
            container.Padding = new Padding(10);

            Panel bubble = new Panel();
            bubble.AutoSize = true;
            bubble.Padding = new Padding(10);

            Label msg = new Label();
            msg.Text = message;
            msg.Padding = new Padding(10, 10, 0, 10); // make sure text is in the middle
            msg.ForeColor = Color.Beige;
            msg.AutoSize = true;
            msg.TextAlign = ContentAlignment.MiddleLeft;
            msg.MaximumSize = new Size(250, 0);

            bubble.Controls.Add(msg);

            if (isRecepient)
            {
                bubble.BackColor = Color.FromArgb(33, 44, 66);
                bubble.Dock = DockStyle.Right; // THIS FIXES ALIGNMENT
            }
            else
            {
                bubble.BackColor = Color.FromArgb(30, 40, 57);
                msg.TextAlign = ContentAlignment.MiddleLeft;
                bubble.Dock = DockStyle.Left;
            }

            container.Controls.Add(bubble);

            chatMessageAppearancePanel.Controls.Add(container);

            chatMessageAppearancePanel.Controls.SetChildIndex(container, 0);

            borderPanel.SetRoundedRegion(bubble, 17); // only after adding them, i can use border
        }

        // =========================
        // HOME BUTTON
        // =========================
        private void homeButton_Click(object sender, EventArgs e)
        {
            if (user_role == "Manager" || user_role == "Admin")
            {
                AdUI home = new AdUI(user_id);
                home.Show();
                this.Close();
            }
            else
            {
                EUI empHome = new EUI(user_role, user_name, user_id);
                empHome.Show();
                this.Hide();
            }
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chatSenderHeadPanel_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(33, 44, 66);

            using (Pen pen = new Pen(borderColor, 2))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panel1.Width - 1,
                    panel1.Height - 1
                );
            }
        }
    }

}