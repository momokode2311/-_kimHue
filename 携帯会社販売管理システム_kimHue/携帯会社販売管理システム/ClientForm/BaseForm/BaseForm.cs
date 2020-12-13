using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 携帯会社販売管理システム
{
    public enum MessageKind: int
    {
        ErrorBox = 0,
        //ClamationBox = 1,
        WarningBox = 2,
        SuccessBox = 4,
    }


    public partial class BaseForm: Form
    {
        /// <summary>
        /// 現在の画面ID
        /// </summary>
        public virtual string FormID { get; set; }

        /// <summary>
        /// 直前画面ID
        /// </summary>
        public virtual string PreviousID { get; set; }

        /// <summary>
        /// ログイン情報
        /// </summary>
        public virtual string UserID { get; set; }

        /// <summary>
        /// ログイン情報
        /// </summary>
        public virtual string UserName { get; set; }


        public void CallForm(Form parent, Form child, String currentId, String previousId)
        {
            FormID = currentId;
            PreviousID = previousId;
            parent.Hide();
            child.Show();

        }
        
        /// <summary>
        /// メッセジーボックスを表示する
        /// </summary>
        /// <returns></returns>
        public DialogResult DisplayMessage(MessageKind messageKind, string msg)
        {
            var rs = new DialogResult();
            switch (messageKind)
            {
                case MessageKind.ErrorBox:
                    rs = MessageBox.Show(msg, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case MessageKind.WarningBox:
                    rs = MessageBox.Show(msg, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;

                case MessageKind.SuccessBox:
                    rs = MessageBox.Show(msg, "成功",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            return rs;

        }

        /// <summary>
        /// 
        /// </summary>
        public void ErrorCatcher(string errMsg)
        {
            //TODO: Write log
        }
    }
}
