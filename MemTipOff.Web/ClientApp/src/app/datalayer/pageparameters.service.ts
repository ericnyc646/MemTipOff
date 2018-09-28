import { Injectable } from '@angular/core';
import { BehaviorSubject} from 'rxjs';

@Injectable()
export class PageParametersService {

    private userselectedsource = new BehaviorSubject('0');
    usersheetselectedtoview = this.userselectedsource.asObservable();

    constructor() {}

    changeUserSelectedSheet(sheetid: string) {
        this.userselectedsource.next(sheetid);
    }

}