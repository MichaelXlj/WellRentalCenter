using Serenity.Navigation;
using MyPages = WellRental.AdminWeb.WellRentalCenter.Pages;

[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/Assignment", typeof(MyPages.AssignmentController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/Order", typeof(MyPages.OrderController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/Merchant", typeof(MyPages.MerchantController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/Merchant Type", typeof(MyPages.MerchantTypeController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/Payment", typeof(MyPages.PaymentController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/Remission", typeof(MyPages.RemissionController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/Wx Open User", typeof(MyPages.WxOpenUserController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/City", typeof(MyPages.CityController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/District", typeof(MyPages.DistrictController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "WellRentalCenter/Province", typeof(MyPages.ProvinceController), icon: null)]