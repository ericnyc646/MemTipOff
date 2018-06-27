export class QuickSheetsModel {
    public id: number;
    public title: string;
    public author: string;
    public description: string;
    public attribution: string;
    public json: string;
    
    constructor(id: number, title: string, author: string,
                description: string, attribution: string,
                json: string) {
        this.id = id;
        this.title = title;
        this.author = author;
        this.description = description;
        this.attribution = attribution;
        this.json = json;
    }
}