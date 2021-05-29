//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace lab_2__WPF_
{
    public class ButtonsField
    {
        private List<Button> Buttons = new List<Button>();
        private sbyte amountButtons = 16;
        private sbyte count = 0;
        private object textBoxForResult;

        public ButtonsField(object textBoxForResult)
        {
            for (int i = 0; i < amountButtons; i++)
            {
                Buttons.Add(new Button());

                Buttons[i].Content = (i + 1).ToString();

                Buttons[i].Width = 30;
                Buttons[i].Height = 20;

                Buttons[i].Click += btn_handler;
            }

            this.textBoxForResult = (textBoxForResult);
        }

        public void drawField(Grid getter)
        {
            sbyte x = 0, y = 0;

            for (int i = 0; i < amountButtons; i++)
            {
                Grid.SetColumn(Buttons[i], 0 + x);
                Grid.SetRow(Buttons[i], 0 + y);
                getter.Children.Add(Buttons[i]);

                x++;
                if ((i + 1) % 4 == 0)
                {
                    y++;
                    x = 0;
                }
            }
            shuffleButtons();
        }

        public void shuffleButtons()
        {
            Random rand = new Random();

            for (int i = 0; i < amountButtons; i++)
            {
                sbyte j = (sbyte)rand.Next(i);

                Point some = new Point(Grid.GetColumn(Buttons[j]), Grid.GetRow(Buttons[j]));

                Grid.SetColumn(Buttons[j], Grid.GetColumn(Buttons[i]));
                Grid.SetRow(Buttons[j], Grid.GetRow(Buttons[i]));

                Grid.SetColumn(Buttons[i], (int)some.X);
                Grid.SetRow(Buttons[i], (int)some.Y);
            }
        }
        private void resetHidingButtons()
        {
            shuffleButtons();
            for (int i = 0; i < amountButtons; i++)
                if (Buttons[i].Visibility == Visibility.Hidden)
                    Buttons[i].Visibility = Visibility.Visible;
            count = 0;
        }

        private void btn_handler(object sender, EventArgs e)
        {
            if (count == (amountButtons - 1))
            {
                (textBoxForResult as TextBox).Text = "ּמכמהוצü!";
                resetHidingButtons();
            }
            else
                (textBoxForResult as TextBox).Text = "";

            if ((sender as Button).Content.ToString() == (count + 1).ToString())
            {
                (sender as Button).Visibility = Visibility.Hidden;
                count++;
                shuffleButtons();
            }
            else
            {
                resetHidingButtons();
                count = 0;
            }
        }
    }
}
