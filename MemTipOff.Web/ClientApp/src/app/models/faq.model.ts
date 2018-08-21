export class FAQs {
    public id: number;
    public categoryName: string;
    public displayOrder: number;
    public displayCategory: boolean;
    public faqs: Array<FAQentries> = [];

    constructor(id: number, categoryName: string, displayOrder: number,
        displayCategory: boolean, faqs: Array<FAQentries>) {
            this.id = id;
            this.categoryName = categoryName;
            this.displayOrder = displayOrder;
            this.displayCategory = displayCategory;
            this.faqs = faqs;
        }
}


export class FAQentries {
    public id: number;
    public categoryId: number;
    public faqname: string;
    public question: string;
    public answer: string;
    public displayOrder: number;
    public displayItem: boolean;
    public category: string;

    constructor( id: number, categoryId: number, faqname: string,
        question: string, answer: string, displayOrder: number,
        displayItem: boolean, category: string) {
            this.id = id;
            this.categoryId = categoryId;
            this.faqname = faqname;
            this.question = question;
            this.answer = answer;
            this.displayOrder = displayOrder;
            this.displayItem = displayItem;
            this.category = category;
        }
}






// [Id] [int] IDENTITY(1,1) NOT NULL,
// [CategoryName] [nvarchar](25) NOT NULL,
// [DisplayOrder] [int] NOT NULL,
// [DisplayCategory] [bit] NOT NULL,