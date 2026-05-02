using System;
using System.Drawing;
using System.Windows.Forms;

public static class HColorPanel //basically  this is commonly used for hovering panel in AdUI / EUI
{
   

    // =========================
    // GROUP HOVER (PANEL + CHILDREN)
    // 
    // =========================
    public static void AddPanelGroupHover(Panel panel, Color hoverColor, Color normalColor)
    {
        void SetAll(Color color)
        {
            SetPanelAndChildren(panel, color);
        }

        // initial state
        SetAll(normalColor);

        panel.MouseEnter += (s, e) =>
        {
            SetAll(hoverColor);
        };

        panel.MouseLeave += (s, e) =>
        {
            if (!IsMouseInside(panel))
                SetAll(normalColor);
        };

        AttachChildEvents(panel, hoverColor, normalColor, SetAll);
    }

    // =========================
    // ATTACH CHILD EVENTS ONCE
    // =========================
    private static void AttachChildEvents(Control parent, Color hoverColor, Color normalColor, Action<Color> setAll)
    {
        foreach (Control ctrl in parent.Controls)
        {
            ctrl.MouseEnter += (s, e) =>
            {
                setAll(hoverColor);
            };

            ctrl.MouseLeave += (s, e) =>
            {
                if (!IsMouseInside(parent))
                    setAll(normalColor);
            };

            if (ctrl.HasChildren)
                AttachChildEvents(ctrl, hoverColor, normalColor, setAll);
        }
    }

    // =========================
    // APPLY COLOR TO PANEL + CHILDREN
    // =========================
    private static void SetPanelAndChildren(Control parent, Color color)
    {
        parent.BackColor = color;

        foreach (Control ctrl in parent.Controls)
        {
            ctrl.BackColor = color;

            if (ctrl.HasChildren)
                SetPanelAndChildren(ctrl, color);
        }
    }

    // =========================
    // MOUSE INSIDE CHECK
    // =========================
    private static bool IsMouseInside(Control ctrl)
    {
        return ctrl.ClientRectangle.Contains(ctrl.PointToClient(Cursor.Position));
    }

}