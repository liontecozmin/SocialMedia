using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SC.Web.Models;
using SC.Web.Models.AccountViewModels;
using SC.Web.Data;
using SC.Web.DataBase;
using SC.Web.DataBase.Profile;


namespace SC.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;
        public string email_user;
        public bool ok = false;
        public string mesaj = "";
        

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILoggerFactory loggerFactory)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = loggerFactory.CreateLogger<AccountController>();
        }
       
        public async void GetUserMail()  //Task
        {
            try
            {
                if (ok == false)
                {
                    var user1 = await GetCurrentUserAsync();
                    email_user = user1.Email;
                    ok = true;
                   
                }
            }
            catch (Exception e){}
        }
        
        public IActionResult AddPost()
        {
            
            ViewData["StatusMessage"] =mesaj;

            return View();
        }

        public IActionResult Posts()
        {

            ViewData["StatusMessage"] = mesaj;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPost(Post model)
        {
            //GetUserMail();
            var user = await GetCurrentUserAsync();
            var context = new PostContext();
            var post = new Post(user.Email, model.group, DateTime.Now, model.message);
            context.Posts.Add(post);
            context.SaveChanges();
            string mesaj = "Your post has been added";
            ViewData["StatusMessage"] = mesaj;
            return View(model);
        }

        public IActionResult AddEmail()
        {
            ViewData["Message"] = "Send emails";

            return View();
        }

        public  IActionResult ViewEmail()
        {
            int number = 0;
            // var user = await GetCurrentUserAsync();
            GetUserMail();
            var context = new EmailContext();
            Storage objects = new Storage();
            objects.mail = new List<Email>() { };
            objects.size = 0;
            int i = 0;
            var mail = new Email();
                     
            foreach (var mail1 in context.Emails)
            {
                if (email_user == mail1.to)
                {
                    mail.id = i + 1 ;
                    mail.from = mail1.from;
                    mail.to = mail1.to;
                    mail.subject = mail1.subject;
                    mail.message = mail1.message;
                    mail.emailDate = mail1.emailDate;
                    objects.mail.Add(mail);
                    mail = new Email();
                    objects.size++;
                    i++;
                }
            }
            return View(objects);
        }

        public IActionResult ViewPosts(Post model)
        {          
            // var user = await GetCurrentUserAsync();
            GetUserMail();
            var context = new PostContext();
            Storage objects = new Storage();
            objects.post = new List<Post>() { };
            objects.size_post = 0;
            int i = 0;
            var post = new Post();

            foreach (var post1 in context.Posts)
            {
                if (model.group == post1.group)
                {
                    post.id = i + 1;
                    post.email = post1.email;
                    post.message = post1.message;
                    post.group = post1.group;
                    post.postDate = post1.postDate;
                    objects.post.Add(post);
                    post = new Post();
                    objects.size_post++;
                    i++;
                }
            }
            return View(objects);
        }

        /*       [HttpPost]
               [HttpGet]
               [ValidateAntiForgeryToken]
               public async Task<IActionResult> ViewEmail()
               {
                   var user = await GetCurrentUserAsync();
                   var mail = new Email();
                   mail.subject = "subbiect";
                   mail.to = "cineva";

                   return View(mail);
               }
       */
        public IActionResult Emails()
        {
            ViewData["Message"] = "View and send emails";


            return View();
        }

        public IActionResult Groups()
        {
            ViewData["Message"] = "Manage Groups";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEmail(Email model)
        {
             var user = await GetCurrentUserAsync();
            //GetUserMail();
            var context = new EmailContext();
            var email = new Email(user.Email,model.to,model.subject,model.message,DateTime.Now);
            context.Emails.Add(email);
            context.SaveChanges();
            string mesaj = "Your email was sent";
            ViewData["StatusMessage"] = mesaj;
            return View(model);
        }


        public IActionResult AddGroup()
        {
            ViewData["Message"] = "Add Group";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddGroup(Group model)
        {
            var user = await GetCurrentUserAsync();

            var context = new GroupContext();
            var group = new Group(user.Email, model.group_name);
            var GroupRepository = new GroupRepository();
            var group1 = GroupRepository.FindGroup(model.group_name);
            if(group1.group_name==group.group_name)
                return View(model);
            context.Groups.Add(group);
            context.SaveChanges();
            string mesaj = "Your group has been created";
            ViewData["StatusMessage"] = mesaj;
            return View(model);
        }
    
         public IActionResult InsertGroup()
         {
               ViewData["Message"] = "Insert Group";
               return View();
         }

                [HttpPost]
                [ValidateAntiForgeryToken]
                public async Task<IActionResult> InsertGroup(Group model)
                {
                        var user = await GetCurrentUserAsync();
                        // GetUserMail();
                        var context = new GroupContext();
                        var group = new Group(user.Email, model.group_name);

                        var GroupRepository = new GroupRepository();
                        var group1 = GroupRepository.FindByGroupName(user.Email, model.group_name);
                        if (group1.group_name == group.group_name && group1.email==group.email)
                            return View(model);

                        context.Groups.Add(group);
                        context.SaveChanges();
                        string mesaj = "Your application was sent";
                        ViewData["StatusMessage"] = mesaj;
                        return View(model);
                }
        
        
        public IActionResult ViewAllGroups()
        {    
            //  var user = await GetCurrentUserAsync();
         //   GetUserMail();
            var context = new GroupContext();
            Storage objects = new Storage();
            objects.group = new List<Group>() { };
            objects.size_group = 0;
            int i = 0;
            var group = new Group();
            int ok = 1;

            foreach (var group1 in context.Groups)
            {
                ok = 1;
                foreach (var group2 in objects.group)
                {
                    if (group1.group_name == group2.group_name)
                        ok = 0;
                }
                if (ok == 0)
                    continue;
                group.group_name = group1.group_name;
                group.email = group1.email;
                objects.group.Add(group);
                    group= new Group();
                    objects.size_group++;
                    i++;
            }
            return View(objects);
        }


        public IActionResult ViewYourGroups()
        {
            //  var user = await GetCurrentUserAsync();
            GetUserMail();
            var context = new GroupContext();
            Storage objects = new Storage();

            objects.group = new List<Group>() { };
            objects.size_group = 0;
            int i = 0;
            var group = new Group();

            foreach (var group1 in context.Groups)
            {
                if (email_user == group1.email)
                {
                    group.group_name = group1.group_name;
                    group.email = group1.email;
                    objects.group.Add(group);
                    group = new Group();
                    objects.size_group++;
                    i++;
                }
            }
            return View(objects);
        }

        public IActionResult LeaveGroup()
        {
            ViewData["Message"] = "Leave Group";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LeaveGroup(Group model)
        {
           var user = await GetCurrentUserAsync();
          //  GetUserMail();
            var context = new GroupContext();
            var GroupRepository = new GroupRepository();
            var group1 = GroupRepository.FindByGroupName(user.Email, model.group_name);
            if(group1.group_name=="")
                return View(model);
            context.Remove(group1);
            context.SaveChanges();
            string mesaj = "You left the group";
            ViewData["StatusMessage"] = mesaj;
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
               
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                email_user = model.Email;
                if (result.Succeeded)
                {
                    _logger.LogInformation(1, "User logged in.");
                    
                    return RedirectToLocal(returnUrl);
                }
                  
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }

          
            return View(model);
        }

     
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

       
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    _logger.LogInformation(3, "User created a new account with password.");
                    UserProfileContext context = new UserProfileContext();
                    UserProfile user1 = new UserProfile(user.Email,"","");
                    context.Add(user1);
                    context.SaveChanges();

                    GroupContext context1 = new GroupContext();
                    Group group1 = new Group(user.Email, "FII");
                    context1.Add(group1);
                    context1.SaveChanges();
                    return RedirectToLocal(returnUrl);
                }
                AddErrors(result);
            }
            return View(model);
        }

  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation(4, "User logged out.");
            return RedirectToAction(nameof(HomeController.Index),"Home");
        }

     

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private Task<ApplicationUser> GetCurrentUserAsync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index),"Home");
            }
        }
 
    }
}
