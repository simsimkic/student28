using System;
using System.Collections.Generic;
using Model.UserModel;

namespace Service.UserService
{
    public interface IArticleService : IService
    {
        Article GetArticleById(String title);
        List<Article> GetAllArticles();
    }
}