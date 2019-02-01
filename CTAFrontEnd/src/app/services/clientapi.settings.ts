export class ClientApiSettings {
  //if NOT using ng serve
  // private static CURRENT_URL = "api/"
  //if using NG Serve
  //localhost
  private static CLIENT_URL = "http://localhost:57485/api/"
  //direct
  // private static CLIENT_URL =
    // "https://calltracker.apps.cac.preview.pcf.manulife.com/api/";
  //prod build
  // private static CLIENT_URL = "api/"

  private static BW_URL = "";

  public static GETBWURL(controller: string): string {
    return this.BW_URL + controller;
  }

  public static GETCLIENTAPIURL(controller: string): string {
    return this.CLIENT_URL + controller;
  }

  public static HANDLEERROR(error: any): Promise<any> {
    console.error("An error occured", error);
    return Promise.reject(error.message || error);
  }
}
