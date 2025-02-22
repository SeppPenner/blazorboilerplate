﻿using BlazorBoilerplate.Shared;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Client.Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task Login(LoginParameters loginParameters);
        Task Register(RegisterParameters registerParameters);
        Task ForgotPassword(ForgotPasswordParameters forgotPasswordParameters);
        Task ResetPassword(ResetPasswordParameters resetPasswordParameters);
        Task Logout();
        Task ConfirmEmail(ConfirmEmailParameters confirmEmailParameters);
        Task<UserInfo> GetUserInfo();
        Task<UserInfo> UpdateUser(UserInfo userInfo);
    }
}
