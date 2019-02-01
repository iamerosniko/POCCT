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
  CallCategory;
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
