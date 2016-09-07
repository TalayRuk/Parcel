using Nancy;
using Parcel.Objects;

namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule() {
      Get["/"] =_=> {
        return View["form.cshtml"];
      };

    }




  }

}
