using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentSystem.Entity
{
    /// <summary>
    /// 企业基本信息表 实体类
    /// </summary>
    class E_CorpBaseInfo
    {
        private string statisticDate;

        public string StatisticDate
        {
            get { return statisticDate; }
            set { statisticDate = value; }
        }
        private string faRenID;

        public string FaRenID
        {
            get { return faRenID; }
            set { faRenID = value; }
        }
        private string tag;

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        private string corpDetailName;

        public string CorpDetailName
        {
            get { return corpDetailName; }
            set { corpDetailName = value; }
        }
        private string oldName;

        public string OldName
        {
            get { return oldName; }
            set { oldName = value; }
        }
        private string faRenName;

        public string FaRenName
        {
            get { return faRenName; }
            set { faRenName = value; }
        }
        private string faRenTel;

        public string FaRenTel
        {
            get { return faRenTel; }
            set { faRenTel = value; }
        }
        private string faRenFax;

        public string FaRenFax
        {
            get { return faRenFax; }
            set { faRenFax = value; }
        }
        private string postalCode;

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
        private string environName;

        public string EnvironName
        {
            get { return environName; }
            set { environName = value; }
        }
        private string environTel;

        public string EnvironTel
        {
            get { return environTel; }
            set { environTel = value; }
        }
        private string environFax;

        public string EnvironFax
        {
            get { return environFax; }
            set { environFax = value; }
        }
        private string corpAddress;

        public string CorpAddress
        {
            get { return corpAddress; }
            set { corpAddress = value; }
        }
        private string adminRegionID;

        public string AdminRegionID
        {
            get { return adminRegionID; }
            set { adminRegionID = value; }
        }
        private string registerTypeID;

        public string RegisterTypeID
        {
            get { return registerTypeID; }
            set { registerTypeID = value; }
        }
        private string industryTypeID;

        public string IndustryTypeID
        {
            get { return industryTypeID; }
            set { industryTypeID = value; }
        }
        private string corpSizeID;

        public string CorpSizeID
        {
            get { return corpSizeID; }
            set { corpSizeID = value; }
        }
        private string corpOpenDate;

        public string CorpOpenDate
        {
            get { return corpOpenDate; }
            set { corpOpenDate = value; }
        }
    }
}
