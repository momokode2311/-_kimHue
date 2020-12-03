using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 携帯会社販売管理システム
{
    public partial class Common
    {


    }

    public partial class ClientId
    {
        public const string Form_001 = "Login";
        public const string Form_002 = "Menu";
        public const string Form_003 = "Product";
        public const string Form_004 = "WareHousing";
        public const string Form_004_01 = "WareHousingInsert";
        //
        public const string Form_006 = "";
        public const string Form_007 = "";
    }

    public partial class MessageManager
    {
        //Error message
        public const string E000 = "想定外エラーが発生しました。\n管理者にご連絡してください。";

        public const string E001 = "ログインIDまた、パスワードが違いました。";
        //public const string E002 = "ログインは失敗しました！";
        
        public const string E003 = "該当データがありません。";

        //Warning message
        public const string W001 = "アプリを終了しますが、\nよろしでしょうか？";

        //Success message
        public const string S001 = "ログインは成功しました!";
        public const string S002 = "検索完了";
    }


}