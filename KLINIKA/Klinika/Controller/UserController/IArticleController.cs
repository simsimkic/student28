using System;
using System.Collections.Generic;
using Model.UserModel;


namespace Controller.UserController
{
    public interface IArticleController : IController
    {
        Article GetArticleById(String title);
        List<Article> GetAllArticles();
    }
}