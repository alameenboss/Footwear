using Footwear.App_Start;
using IdentityManagement.DAL;
using IdentityManagement.Entities;
using IdentityManagement.Utilities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace Footwear.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ActionResult Logout()
        {
            SignInManager.AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        // GET: Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginInfo objLogin, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser oUser = await SignInManager.UserManager.FindByNameAsync(objLogin.UserName);
                if (oUser != null && oUser.Password == objLogin.Password)
                {
                    switch (oUser.Status)
                    {
                        case EnumUserStatus.Pending:
                            ModelState.AddModelError("", "Error: User account has not been verified.");
                            break;
                        case EnumUserStatus.Active:
                            SignInManager.SignIn(oUser, false, false);
                            IList<string> roleList = UserRoleController.GetUserRoles(oUser.Id);
                            foreach (string role in roleList)
                            {
                                UserManager.AddToRole(oUser.Id, role);
                            }

                            //if no return url provided then redirect page based on role
                            if (string.IsNullOrEmpty(returnUrl))
                            {
                                if (roleList.IndexOf("Administrator") >= 0)
                                {
                                    return RedirectToAction("Index", "Admin");
                                }
                                else
                                {
                                    return RedirectToAction("Shop", "Home");
                                }
                            }
                            return RedirectToLocal(returnUrl);

                        case EnumUserStatus.Banned:
                            ModelState.AddModelError("", "Error: User account has been banned.");
                            break;
                        case EnumUserStatus.LockedOut:
                            ModelState.AddModelError("", "Error: User account has been locked out due to multiple login tries.");
                            break;
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Error: Invalid login details.");
                }
            }
            return View(objLogin);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string Name, string Password)
        {
            if (Name == "alameen" && Password == "alameen")
            {
                return RedirectToAction("Shop", "Home");
            }
            return View();
        }
    }
}