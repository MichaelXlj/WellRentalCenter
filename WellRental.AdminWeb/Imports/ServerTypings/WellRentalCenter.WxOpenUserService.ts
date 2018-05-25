namespace WellRental.AdminWeb.WellRentalCenter {
    export namespace WxOpenUserService {
        export const baseUrl = 'WellRentalCenter/WxOpenUser';

        export declare function Create(request: Serenity.SaveRequest<WxOpenUserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<WxOpenUserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<WxOpenUserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<WxOpenUserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "WellRentalCenter/WxOpenUser/Create",
            Update = "WellRentalCenter/WxOpenUser/Update",
            Delete = "WellRentalCenter/WxOpenUser/Delete",
            Retrieve = "WellRentalCenter/WxOpenUser/Retrieve",
            List = "WellRentalCenter/WxOpenUser/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>WxOpenUserService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
