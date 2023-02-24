using System;
using System.Collections.Generic;
using Model.UserModel;

namespace Controller.UserController
{
    public class ArticleDecorator : IArticleController
    {
        private IArticleController iArticleController { get; set; }
        private User user { get; set; }

        public ArticleDecorator(IArticleController iArticleController, User user)
        {
            this.iArticleController = iArticleController;
            this.user = user;
        }

        public object Add(object obj)
        {
            return iArticleController.Add(obj);
        }

        public object Delete(object obj)
        {
            return iArticleController.Delete(obj);
        }

        public object Edit(object obj)
        {
            return iArticleController.Edit(obj);
        }

        public Article GetArticleById(string title)
        {
            return iArticleController.GetArticleById(title);
        }

        public List<Article> GetAllArticles()
        {
            return iArticleController.GetAllArticles();
        }
    }
}