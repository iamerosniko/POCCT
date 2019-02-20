//BTAM
export interface UUser {
  AuthenticationToken?: string;
  AuthorizationToken?: string;
  FirstName?: string;
  LastName?: string;
  UserName?: string;
  Role?: string;
  Services?: UServices[];
}

export interface UServices {
  ServiceName?: string;
  ServiceDesc?: string;
  Attributes?: UAttributes[];
}

export interface UAttributes {
  AttribName?: string;
  AttribDesc?: string;
}
//#CALL TRACKER
export interface CT_Calls {
  CallID?: number;
  CallerPhone?: string;
  user_name?: string;
  DateOfCall?: Date;
  CallerAssocID?: number;
  CallerAssoc?: string;
  CallStatusID?: number;
  CallStatus?: string;
  CallCategoryID?: number;
  CallCategory?:string;
}

export interface CT_CallerAssocs {
  CallerAssocID?: number;
  CallerAssocDesc?: string;
  Active?: boolean;
}

export interface CT_CallCategories {
  CallCategoryID?: number;
  CallCategoryDesc?: string;
  Active?: boolean;
}

export interface CT_CallStatuses {
  CallStatusID?: number;
  CallStatusDesc?: string;
  Active?: boolean;
}

export interface SearchData {
  FromDate?: Date;
  ToDate?: Date;
  GroupByID?: Number;
}

export interface GroupCallerAssoc {
  CallerAssoc ?: string;
  CallerAssocDetails ?: CallerAssocDetails[];
  CallerAssocDetailsTotal ?: number;
}

export interface CallerAssocDetails {
  CallerPhone?:string;
  CSRName?:string;
  DateOfCall?:Date;
  CallStatus?:string;
  CallCategory?:string;
}

export interface GroupCSRName {
  CSRName?:string;
  CSRNameDetails?:CSRNameDetails[];
  CSRNameDetailsTotal ?: number;
}

export interface CSRNameDetails {
  CallerPhone?:string;
  CallerAssoc?:string;
  DateOfCall?:Date;
  CallStatus?:string;
  CallCategory?:string;
}

export interface GroupCallStatus {
  CallStatus?:string;
  CallStatusDetails?:CallStatusDetails[];
  CallStatusDetailsTotal ?: number;
}

export interface CallStatusDetails {
  CallerPhone?:string;
  CallerAssoc?:string;
  CSRName?:string;
  DateOfCall?:Date;
  CallCategory?:string;
}

export interface GroupCallCategory {
  CallCategory?:string;
  CallCategoryDetails?:CallCategoryDetails[];
  CallCategoryDetailsTotal ?: number;
}

export interface CallCategoryDetails {
  CallerPhone?:string;
  CallerAssoc?:string;
  CSRName?:string;
  DateOfCall?:Date;
  CallStatus?:string;
}