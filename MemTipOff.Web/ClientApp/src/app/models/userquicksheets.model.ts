export class UserQuickSheetsModel {
    public id: number;
    public title: string;
    public authorid: number;
    public description: string;
    public attribution: string;

    constructor(id: number, title: string, authorid: number, 
        description: string, attribution: string) {
        this.id = id;
        this.title = title;
        this.authorid = authorid;
        this.description = description;
        this.attribution = attribution;
    }
}