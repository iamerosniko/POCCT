//BTAM
export interface UUser {
  AuthenticationToken?: string;
  AuthorizationToken?: string;
  FirstName?: string;
  LastName?: string;
  Role?: string;
  Services?:UServices[];
}

export interface UServices{
    ServiceName?:string,
    ServiceDesc?:string,
    Attributes?:UAttributes[]
}

export interface UAttributes{
    AttribName?:string,
    AttribDesc?:string,
}
//#CALL TRACKER