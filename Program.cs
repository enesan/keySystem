using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// rows.count сделать под размер таблицы
// если успешно добавлен вречную, то рядом появляется значок галочки
// При нажатии на кнопку уборщицы вылезает окно с подтверждением
// Проверка логина и пароля
// в ручном добавлении проверка на количество цифр в айдишнике

namespace Key_systemAlpha
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Boss());
        }
    }
}
