﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalAboutEverything.LocalizationResources.BoardGame {
    using System;


    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class BoardGame_CreateAndUpdateReview {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BoardGame_CreateAndUpdateReview() {
        }

        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PortalAboutEverything.LocalizationResources.BoardGame.BoardGame_CreateAndUpdateRe" +
                            "view", typeof(BoardGame_CreateAndUpdateReview).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Ищет локализованную строку, похожую на Post a review.
        /// </summary>
        public static string CreateButton {
            get {
                return ResourceManager.GetString("CreateButton", resourceCulture);
            }
        }

        /// <summary>
        ///   Ищет локализованную строку, похожую на Review.
        /// </summary>
        public static string DisplayText_Name {
            get {
                return ResourceManager.GetString("DisplayText_Name", resourceCulture);
            }
        }

        /// <summary>
        ///   Ищет локализованную строку, похожую на The review cannot be empty.
        /// </summary>
        public static string RequiredText_ErrorMessage {
            get {
                return ResourceManager.GetString("RequiredText_ErrorMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Ищет локализованную строку, похожую на Your review.
        /// </summary>
        public static string Text {
            get {
                return ResourceManager.GetString("Text", resourceCulture);
            }
        }

        /// <summary>
        ///   Ищет локализованную строку, похожую на Write your opinion about the game.
        /// </summary>
        public static string TitleOfPageCreate {
            get {
                return ResourceManager.GetString("TitleOfPageCreate", resourceCulture);
            }
        }

        /// <summary>
        ///   Ищет локализованную строку, похожую на Your opinion about the game.
        /// </summary>
        public static string TitleOfPageUpdate {
            get {
                return ResourceManager.GetString("TitleOfPageUpdate", resourceCulture);
            }
        }

        /// <summary>
        ///   Ищет локализованную строку, похожую на Edit a review.
        /// </summary>
        public static string UpdateButton {
            get {
                return ResourceManager.GetString("UpdateButton", resourceCulture);
            }
        }
    }
}
