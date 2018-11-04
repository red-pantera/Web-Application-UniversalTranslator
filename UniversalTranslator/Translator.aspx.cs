using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversalTranslator
{
    public partial class Translator : System.Web.UI.Page
    {
        TranslatorClass TransClass;
        private void Page_Load(object sender, System.EventArgs e)
        // Переконатися, що змінна стану Session існує.
        {
            if (Session["TransClass"] != null)
                // Отримати об'єкт TransClass з змінної стану Session
                TransClass = (TranslatorClass)Session["TransClass"];
        }

        protected void butTranslate_Click(object sender, EventArgs e)

        {
            // Оголосити змінну-"перемикач" типу bool
            bool bSwitch;
            // Переконатися, що змінна ViewState існує
            if (ViewState["bSwitch"] != null)
                // Отримати значення "перемикача" з ViewState та інвертувати його.
                bSwitch = !(bool)ViewState["bSwitch"];
            else
                // Задати значення "перемикача".
                bSwitch = true;
            // Зберегти нове значення в ViewState.
            ViewState["bSwitch"] = bSwitch;
            // Транслювати текст, введений в текстовому полі TextBoxl, або повернути
            // Його в початковий вигляд, в залежності від значення "перемикача",
            if (bSwitch)
            {
                // Отриати текст.
                TransClass.Text = txtSource.Text;
                // Транслювати текст.
                TransClass.Translate();
                // Показати текст.
                txtSource.Text = TransClass.Text;
                // Помінятин надпис на кнопці.
                butTranslate.Text = "Restore";
            }
            else
            {
                // Повернути текст в початковий вид.
                TransClass.Restore();
                //Показати текст
                txtSource.Text = TransClass.Text;
                // Поміняти надпис на кнопці
                butTranslate.Text = "Translate";
            }
        }
    }
}


