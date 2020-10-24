export class Marcador {
    public lat: number;
    public lng: number;
    public obs:string;
    constructor(lat: number, lng: number,obs:string) {
        this.lat = lat;
        this.lng = lng;
        this.obs = obs;
    }

}