using Dapper;
using lightPayrollModel;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace lightPayrollServices
{
    public class ChatService
    {
        private string _connectionString;

        public ChatService(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SQLiteConnection GetConnection()
            => new SQLiteConnection(_connectionString);

        // =========================
        // SAVE MESSAGE
        // =========================
        public void SaveMessage(ChatMessage msg)
        {
            using (var con = GetConnection())
            {
                string sql = @"
                INSERT INTO ChatMessages
                (
                    SenderID,
                    ReceiverID,
                    Message,
                    SentAt
                )
                VALUES
                (
                    @SenderID,
                    @ReceiverID,
                    @Message,
                    @SentAt
                )";

                con.Execute(sql, msg);
            }
        }

        // =========================
        // LOAD CONVERSATION
        // =========================
        public ChatUserTag GetAdminUser()
        {
            using (var con = GetConnection())
            {
                string sql = @"
        SELECT
            EmployeeID AS Id,
            FirstName || ' ' || LastName AS Name
        FROM EmployeesTable
        WHERE Position = 'Admin'
        LIMIT 1";

                return con.QueryFirstOrDefault<ChatUserTag>(sql);
            }
        }
        public List<ChatUserTag> GetChatUsersForAdmin(int adminId)
        {
            using (var con = GetConnection())
            {
                string sql = @"
        SELECT DISTINCT
            e.EmployeeID AS Id,
            e.FirstName || ' ' || e.LastName AS Name
        FROM ChatMessages c
        INNER JOIN EmployeesTable e
            ON e.EmployeeID = c.SenderID
        WHERE c.ReceiverID = @adminId
        ORDER BY Name ASC";

                return con.Query<ChatUserTag>(
                    sql,
                    new { adminId }
                ).ToList();
            }
        }
        public List<ChatMessage> GetConversation(int user1, int user2)
        {
            using (var con = GetConnection())
            {
                string sql = @"
                SELECT *
                FROM ChatMessages
                WHERE
                    (SenderID = @user1 AND ReceiverID = @user2)
                    OR
                    (SenderID = @user2 AND ReceiverID = @user1)
                ORDER BY MessageID ASC";

                return con.Query<ChatMessage>(
                    sql,
                    new
                    {
                        user1,
                        user2
                    }).ToList();
            }
        }
    }
}