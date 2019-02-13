using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectByAlice
{
    public class MyCanvas
    {
        public const int maxWidth = 800;
        public const int maxHeight = 600;
        private static int buttonIndex = 0;
        private static MyButton[] buttons = new MyButton[MaxButtons];
        private static int MaxButtons = 3;



        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            bool emptyButtonAvailable = true;
            if (buttonIndex < MaxButtons)
            {
                Point NewPoint_TopLeft = new Point(x1, y1);
                Point NewPoint_BottomRight = new Point(x2, y2);
                buttons[buttonIndex].SetTopLeft(NewPoint_TopLeft);
                buttons[buttonIndex].SetBottomRight(NewPoint_BottomRight);
                buttonIndex++;
                emptyButtonAvailable = true;
            }
            else
                emptyButtonAvailable = false;
            return emptyButtonAvailable;
        }

        public static bool MoveButton(int buttonNumber, int x, int y)
        {

            int oldX, oldY;
            oldX = buttons[buttonNumber].GetBottomRight().GetX();
            oldY = buttons[buttonNumber].GetBottomRight().GetY();
            buttons[buttonNumber].SetBottomRight(new Point(oldX + x, oldY + y));
            oldX = buttons[buttonNumber].GetTopLeft().GetX();
            oldY = buttons[buttonNumber].GetTopLeft().GetY();
            buttons[buttonNumber].SetTopLeft(new Point(oldX + x, oldY + y));

            return true;
        }

        public static bool DeleteLastButton()
        {
            if (buttonIndex > 0)
            {
                buttons[buttonIndex].SetTopLeft(new Point(0, 0));
                buttons[buttonIndex].SetBottomRight(new Point(0, 0));
                buttonIndex--;
                return true;
            }
            else
                return false;
        }

        public static void ClearAllButtons()
        {
            if (buttonIndex > 0)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].SetTopLeft(new Point(0, 0));
                    buttons[i].SetBottomRight(new Point(0, 0));
                }
                buttonIndex = 0;
            }
        }

        public static int GetCurrentNumberOfButtons()
        {
            return buttonIndex;
        }

        public static int GetMaxNumberOfButtons()
        {
            return MaxButtons;
        }

        public static int GetTheMaxWidthOfAButton()
        {
            int MaxWidthOfAButton = 0;
            if (buttonIndex > 0)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if ((buttons[i].GetBottomRight().GetX() - buttons[i].GetTopLeft().GetX()) > MaxWidthOfAButton)
                        MaxWidthOfAButton = buttons[i].GetBottomRight().GetX() - buttons[i].GetTopLeft().GetX();
                }
                return MaxWidthOfAButton;
            }
            else
            {
                return 0;
            }
        }

        public static int GetTheMaxHeightOfAButton()
        {
            int MaxHightOfAButton = 0;
            if (buttonIndex > 0)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if ((buttons[i].GetTopLeft().GetY() - buttons[i].GetBottomRight().GetY()) > MaxHightOfAButton)
                        MaxHightOfAButton = buttons[i].GetBottomRight().GetX() - buttons[i].GetTopLeft().GetX();
                }
                return MaxHightOfAButton;
            }
            else
            {
                return 0;
            }
        }


        public static bool IsPointInsideAButton(int x, int y)
        {
            return true;
        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
