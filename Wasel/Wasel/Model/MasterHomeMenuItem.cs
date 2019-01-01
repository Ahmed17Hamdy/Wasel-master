using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasel.View.HomePage;

namespace Wasel.View.MasterMenuPage
{

    public class MasterHomeMenuItem
    {
        public MasterHomeMenuItem()
        {
            NextPage = typeof(MenuPage);
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public Type NextPage { get; set; }

        
        public ObservableCollection<MasterHomeMenuItem> MenuItems()
        {
            ObservableCollection<MasterHomeMenuItem> items = new ObservableCollection<MasterHomeMenuItem>
            {
                new MasterHomeMenuItem
                {
                    Title="الرئيسية" , Url="Next.png" , NextPage=typeof(MainPage)
                },
                new MasterHomeMenuItem
                {
                    Title="حجز وإيجار شقق" , Url="Next.png" ,  NextPage=typeof(FlatPage)
                },
                new MasterHomeMenuItem
                {
                    Title="حجز طيران" , Url="Next.png", NextPage=typeof(TravelPage)
                },
                new MasterHomeMenuItem
                {
                    Title="قاعات المناسبات" , Url="Next.png", NextPage=typeof(HallPage)
                },
                new MasterHomeMenuItem
                {
                    Title="الصيانة" , Url="Next.png" , NextPage=typeof(MaintenancePage)
                },
                new MasterHomeMenuItem
                {
                    Title="المتجر" , Url="Next.png" , NextPage=typeof(StorePage)
                },
                new MasterHomeMenuItem
                {
                    Title="الطلبات" , Url="Next.png" , NextPage=typeof(OrderPage)
                },
                new MasterHomeMenuItem
                {
                    Title="الصفحة الشخصية" , Url="account_box.png" , NextPage=typeof(ProfilePage)
                },
                new MasterHomeMenuItem
                {
                    Title="اتصل بنا" , Url="Next.png", NextPage=typeof(AboutUsPage)
                },

            };
            return items;
        }
    }
}