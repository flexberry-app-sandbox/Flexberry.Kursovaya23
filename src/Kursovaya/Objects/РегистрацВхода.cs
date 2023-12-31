﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Kursovaya
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Регистрац входа.
    /// </summary>
    // *** Start programmer edit section *** (РегистрацВхода CustomAttributes)

    // *** End programmer edit section *** (РегистрацВхода CustomAttributes)
    [AutoAltered()]
    [Caption("Регистрация входа")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("РегистрацВходаE", new string[] {
            "Дата as \'Дата\'",
            "Комната as \'Комната\'",
            "Комната.НомерКомнаты as \'Комната\'"}, Hidden=new string[] {
            "Комната.НомерКомнаты"})]
    [AssociatedDetailViewAttribute("РегистрацВходаE", "ВходГостя", "ВходГостяE", true, "", "Вход гостя", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("РегистрацВходаE", "ВходСотрудника", "ВходСотрудникаE", true, "", "Вход сотрудника", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("РегистрацВходаE", "Комната", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "НомерКомнаты")]
    [View("РегистрацВходаL", new string[] {
            "Дата as \'Дата\'",
            "Комната.НомерКомнаты as \'Комната\'"})]
    public class РегистрацВхода : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата = System.DateTime.Now;
        
        private IIS.Kursovaya.Комната fКомната;
        
        private IIS.Kursovaya.DetailArrayOfВходГостя fВходГостя;
        
        private IIS.Kursovaya.DetailArrayOfВходСотрудника fВходСотрудника;
        
        // *** Start programmer edit section *** (РегистрацВхода CustomMembers)

        // *** End programmer edit section *** (РегистрацВхода CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (РегистрацВхода.Дата CustomAttributes)

        // *** End programmer edit section *** (РегистрацВхода.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (РегистрацВхода.Дата Get start)

                // *** End programmer edit section *** (РегистрацВхода.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (РегистрацВхода.Дата Get end)

                // *** End programmer edit section *** (РегистрацВхода.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистрацВхода.Дата Set start)

                // *** End programmer edit section *** (РегистрацВхода.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (РегистрацВхода.Дата Set end)

                // *** End programmer edit section *** (РегистрацВхода.Дата Set end)
            }
        }
        
        /// <summary>
        /// Регистрац входа.
        /// </summary>
        // *** Start programmer edit section *** (РегистрацВхода.Комната CustomAttributes)

        // *** End programmer edit section *** (РегистрацВхода.Комната CustomAttributes)
        [PropertyStorage(new string[] {
                "Комната"})]
        [NotNull()]
        public virtual IIS.Kursovaya.Комната Комната
        {
            get
            {
                // *** Start programmer edit section *** (РегистрацВхода.Комната Get start)

                // *** End programmer edit section *** (РегистрацВхода.Комната Get start)
                IIS.Kursovaya.Комната result = this.fКомната;
                // *** Start programmer edit section *** (РегистрацВхода.Комната Get end)

                // *** End programmer edit section *** (РегистрацВхода.Комната Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистрацВхода.Комната Set start)

                // *** End programmer edit section *** (РегистрацВхода.Комната Set start)
                this.fКомната = value;
                // *** Start programmer edit section *** (РегистрацВхода.Комната Set end)

                // *** End programmer edit section *** (РегистрацВхода.Комната Set end)
            }
        }
        
        /// <summary>
        /// Регистрац входа.
        /// </summary>
        // *** Start programmer edit section *** (РегистрацВхода.ВходГостя CustomAttributes)

        // *** End programmer edit section *** (РегистрацВхода.ВходГостя CustomAttributes)
        public virtual IIS.Kursovaya.DetailArrayOfВходГостя ВходГостя
        {
            get
            {
                // *** Start programmer edit section *** (РегистрацВхода.ВходГостя Get start)

                // *** End programmer edit section *** (РегистрацВхода.ВходГостя Get start)
                if ((this.fВходГостя == null))
                {
                    this.fВходГостя = new IIS.Kursovaya.DetailArrayOfВходГостя(this);
                }
                IIS.Kursovaya.DetailArrayOfВходГостя result = this.fВходГостя;
                // *** Start programmer edit section *** (РегистрацВхода.ВходГостя Get end)

                // *** End programmer edit section *** (РегистрацВхода.ВходГостя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистрацВхода.ВходГостя Set start)

                // *** End programmer edit section *** (РегистрацВхода.ВходГостя Set start)
                this.fВходГостя = value;
                // *** Start programmer edit section *** (РегистрацВхода.ВходГостя Set end)

                // *** End programmer edit section *** (РегистрацВхода.ВходГостя Set end)
            }
        }
        
        /// <summary>
        /// Регистрац входа.
        /// </summary>
        // *** Start programmer edit section *** (РегистрацВхода.ВходСотрудника CustomAttributes)

        // *** End programmer edit section *** (РегистрацВхода.ВходСотрудника CustomAttributes)
        public virtual IIS.Kursovaya.DetailArrayOfВходСотрудника ВходСотрудника
        {
            get
            {
                // *** Start programmer edit section *** (РегистрацВхода.ВходСотрудника Get start)

                // *** End programmer edit section *** (РегистрацВхода.ВходСотрудника Get start)
                if ((this.fВходСотрудника == null))
                {
                    this.fВходСотрудника = new IIS.Kursovaya.DetailArrayOfВходСотрудника(this);
                }
                IIS.Kursovaya.DetailArrayOfВходСотрудника result = this.fВходСотрудника;
                // *** Start programmer edit section *** (РегистрацВхода.ВходСотрудника Get end)

                // *** End programmer edit section *** (РегистрацВхода.ВходСотрудника Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистрацВхода.ВходСотрудника Set start)

                // *** End programmer edit section *** (РегистрацВхода.ВходСотрудника Set start)
                this.fВходСотрудника = value;
                // *** Start programmer edit section *** (РегистрацВхода.ВходСотрудника Set end)

                // *** End programmer edit section *** (РегистрацВхода.ВходСотрудника Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "РегистрацВходаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РегистрацВходаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РегистрацВходаE", typeof(IIS.Kursovaya.РегистрацВхода));
                }
            }
            
            /// <summary>
            /// "РегистрацВходаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РегистрацВходаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РегистрацВходаL", typeof(IIS.Kursovaya.РегистрацВхода));
                }
            }
        }
    }
}
