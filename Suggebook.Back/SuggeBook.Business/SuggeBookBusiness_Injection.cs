﻿using Microsoft.Extensions.DependencyInjection;
using SuggeBook.Business.Commands.Contracts;
using SuggeBook.Business.Commands.Implementations;
using SuggeBook.Business.Contracts;
using SuggeBook.Business.Implementations;
using SuggeBook.Business.Interactors.Contracts;
using SuggeBook.Business.Services.Contracts;
using SuggeBook.Business.Services.Implementations;
using SuggeBook.Dto.Models;
using SuggeBookDAL.Dao;

namespace SuggeBook.Business
{
    public static class SuggeBookBusiness_Injection
    {
        public static void Add_Business(this IServiceCollection services)
        {
            #region Commands
            services.AddSingleton<IInsertSuggestionCommandHandler, InsertSuggestionCommandHandler>();
            services.AddSingleton<IInsertBookCommandHandler, InsertBookCommandHandler>();
            services.AddSingleton<IInsertAuthorCommandHandler, InsertAuthorCommandHandler>();
            #endregion

            #region Interactors
            services.AddSingleton<ISuggestionInteractor, SuggestionInteractor>();
            services.AddSingleton<IBookInteractor, BookInteractor>();
            services.AddSingleton(typeof(IBaseInteractor<,>), typeof(BaseInteractor<,>));
            #endregion

            #region Services
            services.AddSingleton<ISuggestionService, SuggestionService>();
            services.AddSingleton<IBookService, BookService>();
            services.AddSingleton<IAuthorService, AuthorService>();

            #endregion
        }
    }
}
