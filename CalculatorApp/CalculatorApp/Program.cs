﻿using System;
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

        var buttonPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            RowCount = 5,
            ColumnCount = 4,
            BackColor = Color.LightGray,
            Padding = new Padding(10)
        };

        string[,] buttons = new string[,]
        {
            { "7", "8", "9", "/" },
            { "4", "5", "6", "*" },
            { "1", "2", "3", "-" },
            { "0", ".", "=", "+" },
            { "C", "(", ")", "%" }
        };

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                var button = new Button
                {
                    Text = buttons[row, col],
                    Font = new Font("Arial", 24, FontStyle.Bold),
                    Height = 70,
                    Dock = DockStyle.Fill,
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(5),
                    R
                };
                buttonPanel.Controls.Add(button, col, row);
            };
        };
        Controls.Add(buttonPanel);
        Controls.Add(displayPanel);
    }
}