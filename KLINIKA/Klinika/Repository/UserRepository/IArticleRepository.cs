using Model.UserModel;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
    public interface IArticleRepository : IRepository
    {
        Article GetArticleById(String title);
        List<Article> GetAllArticles();
    }
}