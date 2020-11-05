namespace SocialMediaForStudents.Web.Areas.Administration.Controllers
{
    using SocialMediaForStudents.Common;
    using SocialMediaForStudents.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
