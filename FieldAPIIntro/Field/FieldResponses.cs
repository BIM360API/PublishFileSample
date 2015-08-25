﻿#region Copyright
//
// Copyright (C) 2015 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
//
// Written by M.Harada
// 
#endregion // Copyright

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFieldWorld
{
    [Serializable] 
    public class LoginResponse
    {
        public string ticket { get; set; }
        public string message { get; set; }
        public string title { get; set; }
    }

    //[Serializable] 
    //public class ProjectNamesResponse  
    //{
    //    public List<Project> project_names { get; set; }
    //    public int page { get; set; } 
    //}

    [Serializable]
    public class Project
    {
        public string id { get; set; }
        public string name { get; set; }
        //public string a360_project_id { get; set; }
        public string updated_at { get; set; }
    }

    [Serializable]
    public class Issue
    {
        public string id { get; set; }
        public string created_by { get; set; }
        //public string fields { get; set; }
        //public IssueFieldItem[] fields { get; set; } 
        public List<IssueFieldItem> fields { get; set; }
        public List<Object> comments { get; set; }
        public List<Object> attachments { get; set; }
    }

    [Serializable]
    public class IssueFieldItem
    {
        public string id { get; set; }
        public string name { get; set; }
        public string display_type { get; set; }
        public string value { get; set; }
    }

    [Serializable]
    public class IssueCreateResponse 
    {
        public bool success { get; set; }
        public List<object> general_errors { get; set; }
        public List<object> errors { get; set; }
        public string id { get; set; }
        public string temporary_id { get; set; }
    }

    [Serializable]
    public class Equipment 
    {
        public string equipment_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string serial_number { get; set; }
        public string created_by { get; set; }
        public string tag_number { get; set; }
        public string barcode { get; set; }
        public string asset_identifier { get; set; }
        public string purchase_order { get; set; }
        public string submittal { get; set; }
        public string purchase_date { get; set; }
        public string install_date { get; set; }
        public string warranty_start_date { get; set; }
        public string warranty_end_date { get; set; }
        public int expected_life { get; set; }
        public string area_id { get; set; }
        public string equipment_type_id { get; set; }
        public string equipment_status_id { get; set; }
        public string parent_id { get; set; }
        public string bim_file_id { get; set; }
        public string bim_object_identifier { get; set; }
        public string source { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public bool deleted { get; set; }
        public List<object> comments { get; set; }
        public List<object> document_references { get; set; }
        public List<object> document_folder_references { get; set; }
        public List<object> attachments { get; set; }
        public List<object> signatures { get; set; }
        public List<object> uri_references { get; set; }
        public List<object> custom_field_values { get; set; }
        public List<object> audits { get; set; }
        public List<object> checklists { get; set; }
        public List<object> completed_checklists { get; set; }
        public bool downloaded { get; set; }
    }

}
