using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class Caclulator
    {
        public List<Button> buttonsList = new List<Button>();
        public TextBox inputField;
        private double result;
        private double operand1, operand2;
        private int operation;
        private bool reuseOperation = false;


        public Button CreateButton(int posX, int posY, string text)
        {
            Button b = new Button();
            b.Location = new Point(posX, posY);
            b.Size = new Size(70, 70);
            b.Text = text;
            b.BackColor = Color.White;
            b.Font = new Font("Arial", 15f, FontStyle.Regular);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;

            return b;
        }
        public void CreateNumberField(Form f)
        {
            inputField = new TextBox();
            inputField.Location = new Point(10, 10);
            inputField.Multiline = true;
            inputField.Size = new Size(290, 30);
            inputField.TextAlign = HorizontalAlignment.Right;
            inputField.Font = new Font("Arial", 14f, FontStyle.Regular);
            inputField.BorderStyle = BorderStyle.Fixed3D;
            f.Controls.Add(inputField);

            Button btn;

            int margin = 70;
            //starting coordinates
            int X = 0, Y = 50;
            //text in the button
            int text = 7;
            int rowCounter = 0;
            for (int i = 0; i < 9; i++)
            {
                if (rowCounter < 2)
                {
                    btn = CreateButton(X, Y, text.ToString());
                    X += margin;
                    rowCounter++;
                    text++;

                }
                else
                {
                    btn = CreateButton(X, Y, text.ToString());
                    X = 0;
                    Y += margin;
                    rowCounter = 0;
                    text -= 5;
                }

                buttonsList.Add(btn);
            }

            //create '+/-'
            btn = CreateButton(X, Y, "+/-");
            btn.ForeColor = Color.FromArgb(255, 94, 0);
            buttonsList.Add(btn);
            X += margin;

            //create zero
            btn = CreateButton(X, Y, 0.ToString());
            buttonsList.Add(btn);
            //dot
            X += margin;
            btn = CreateButton(X, Y, ",");
            buttonsList.Add(btn);

            //modulo division
            Y = 50;
            X += margin;
            btn = CreateButton(X, Y, "%");
            btn.ForeColor = Color.FromArgb(255, 94, 0);
            buttonsList.Add(btn);

            //clear one digit
            X += margin;
            btn = CreateButton(X, Y, Convert.ToChar('\u232B').ToString());
            btn.ForeColor = Color.FromArgb(255, 94, 0);
            buttonsList.Add(btn);

            //product sign
            Y += margin;
            X -= margin;
            btn = CreateButton(X, Y, "x");
            btn.ForeColor = Color.FromArgb(255, 94, 0);
            buttonsList.Add(btn);

            //division sign
            X += margin;
            btn = CreateButton(X, Y, "/");
            btn.ForeColor = Color.FromArgb(255, 94, 0);
            buttonsList.Add(btn);

            //plus sign
            Y += margin;
            X -= margin;
            btn = CreateButton(X, Y, "+");
            btn.ForeColor = Color.FromArgb(255, 94, 0);
            btn.Size = new Size(70, 140);
            buttonsList.Add(btn);

            //minus sign
            X += margin;
            btn = CreateButton(X, Y, "-");
            btn.ForeColor = Color.FromArgb(255, 94, 0);
            buttonsList.Add(btn);

            //equal sign
            Y += margin;
            btn = CreateButton(X, Y, "=");
            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(255, 94, 0);
            buttonsList.Add(btn);

            //create "Clear Everything Button"
            btn = CreateButton(305, 10, "C");
            btn.Height = 30;
            btn.Width = 40;
            btn.ForeColor = Color.White;
            btn.BackColor = Color.Gray;
            buttonsList.Add(btn);

        }
        public void Display(List<Button> butlist, Form f)
        {
            AddFunctions();
            foreach (var d in butlist)
            {
                f.Controls.Add(d);
            }
        }

        public void AddFunctions()
        {
            foreach(Button b in buttonsList)
            {
                b.Click += new EventHandler(ButtonClick);
            }
        }

        public void ButtonClick(object sender, EventArgs e)
        {

            switch((sender as Button).Text)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    TypeChar(sender as Button);
                    break;
                //checking if inputField is empty
                case "0":
                    if (inputField.Text == "") {
                        TypeChar(sender as Button);
                        break;
                    }                       
                    else
                        TypeChar(sender as Button);
                    break;
                case ",":
                    if (inputField.Text == "")
                    {
                        inputField.Text = "0";
                        TypeChar(sender as Button);
                        break;
                    }
                    if (inputField.Text.Contains(','))
                        break;
                   
                        TypeChar(sender as Button);
                        break;
                case "\u232B":
                    if (inputField.Text != "") 
                        inputField.Text = inputField.Text.Remove(inputField.Text.Length - 1);
                    break;
                case "C":
                    inputField.Clear();
                    operand1 = 0;
                    operand2 = 0;
                    result = 0;
                    break;
                case "+/-":
                    if(inputField.Text != "")
                        inputField.Text = (0 - Convert.ToDouble(inputField.Text)).ToString();
                    break;
                //operations codes:
                //1 - '+'
                //2 - '-'
                //3 - '*'
                //4 - '/'
                //5 - '%' 
                case "+":
                case "-":
                case "x":
                case "/":
                case "%":
                    if(inputField.Text != "")
                    { 
                        reuseOperation = false;         
                        operand1 = Convert.ToDouble(inputField.Text);
                        inputField.Clear();
                        switch((sender as Button).Text)
                        {
                            case "+": operation = 1; break;
                            case "-": operation = 2; break;
                            case "x": operation = 3; break;
                            case "/": operation = 4; break;
                            case "%": operation = 5; break;
                        }
                    }
                    break;
                case "=":
                    if (inputField.Text != "")
                    {
                        if (!reuseOperation)
                             operand2 = Convert.ToDouble(inputField.Text);
                    
                        switch (operation)
                        {
                            case 1:
                                if (reuseOperation)
                                {
                                    result += operand2;
                                }
                                else
                                {
                                    result = operand1 + operand2;
                                }
                                reuseOperation = true; 
                                inputField.Text = result.ToString();
                                break;
                            case 2:
                                if (reuseOperation)
                                {
                                    result -= operand2;
                                }
                                else
                                {
                                    result = operand1 - operand2;
                                }
                                reuseOperation = true;
                                inputField.Text = result.ToString();
                                break;
                            case 3:
                                if (reuseOperation)
                                {
                                    result *= operand2;
                                }
                                else
                                {
                                    result = operand1 * operand2;
                                }
                                reuseOperation = true;
                                inputField.Text = result.ToString();
                                break;
                            case 4:
                                if (reuseOperation)
                                {
                                    result /= operand2;
                                }
                                else
                                {
                                    result = operand1 / operand2;
                                }
                                reuseOperation = true;
                                inputField.Text = result.ToString();
                                break;
                            case 5:
                                if (reuseOperation)
                                {
                                    result %= operand2;
                                }
                                else
                                {
                                    result = operand1 % operand2;
                                }
                                reuseOperation = true;
                                inputField.Text = result.ToString();
                                break;
                        }
                        
                    }
                    break;
            }
        }
        
        private void TypeChar(Button b)
        {
                  
            inputField.Text += b.Text;
            
        }
    }
}
