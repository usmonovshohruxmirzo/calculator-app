using System;
using System.Windows.Forms;
using System.Drawing;

public class Program : Form
{
    private TextBox display;
    private string currentInput = "";
    private double firstOperand;
    private string currentOperation;

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Program());
    }

    public Program()
    {
        Text = "Calculator App";
        Width = 400;
        Height = 450;
        BackColor = Color.LightGray;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;

        var displayPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 80,
            Padding = new Padding(0, 0, 0, 10) 
        };

        display = new TextBox
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            TextAlign = HorizontalAlignment.Right,
            Font = new Font("Arial", 24, FontStyle.Bold),
            BackColor = Color.White,
            BorderStyle = BorderStyle.None,
            ForeColor = Color.Black,
            MaxLength = 15 
        };

        displayPanel.Controls.Add(display);
    }
}