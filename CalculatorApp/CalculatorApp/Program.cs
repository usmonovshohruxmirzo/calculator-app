using System;
using System.Windows.Forms;
using System.Drawing;

public class Program : Form {
    private TextBox display;
    private string currenyInput = "";
    private double firstOperand;
    private string currentOperation;

    [STAThread]

    public static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Program());
    }

    public Program() {
        Text = "Calculator App";
        Width = 400;
        Height = 450;
        BackColor = Color.Red;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
    }
}