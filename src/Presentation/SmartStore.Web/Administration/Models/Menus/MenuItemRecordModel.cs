﻿using System.Collections.Generic;
using FluentValidation;
using FluentValidation.Attributes;
using SmartStore.Core.Localization;
using SmartStore.Web.Framework;
using SmartStore.Web.Framework.Localization;
using SmartStore.Web.Framework.Modelling;

namespace SmartStore.Admin.Models.Menus
{
    [Validator(typeof(MenuItemRecordValidator))]
    public class MenuItemRecordModel : EntityModelBase, ILocalizedModel<MenuItemRecordLocalizedModel>
    {
        public MenuItemRecordModel()
        {
            Locales = new List<MenuItemRecordLocalizedModel>();
        }

        public int MenuId { get; set; }
        public string Model { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.ParentItem")]
        public int ParentItemId { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.Provider")]
        public string SystemName { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Title")]
        public string Title { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.ShortDescription")]
        public string ShortDescription { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.Published")]
        public bool Published { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.IsDivider")]
        public bool IsDivider { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.ShowExpanded")]
        public bool ShowExpanded { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.NoFollow")]
        public bool NoFollow { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.NewWindow")]
        public bool NewWindow { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.HtmlId")]
        public string HtmlId { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.CssClass")]
        public string CssClass { get; set; }

        public IList<MenuItemRecordLocalizedModel> Locales { get; set; }
    }


    public class MenuItemRecordLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Title")]
        public string Title { get; set; }

        [SmartResourceDisplayName("Admin.ContentManagement.Menus.Item.ShortDescription")]
        public string ShortDescription { get; set; }
    }


    public partial class MenuItemRecordValidator : AbstractValidator<MenuItemRecordModel>
    {
        public MenuItemRecordValidator(Localizer T)
        {
            RuleFor(x => x.SystemName).NotEmpty();
        }
    }
}