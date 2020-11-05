import { Component } from '@angular/core';
import { ConfigService } from './services/config.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SumSmallest';

  /**
   *
   */
  constructor(private service:ConfigService) {}

  result:number;
  numbersInString:string;

  callService(){

    let numbers:Array<number> = [];

    let numberInArray = this.numbersInString.split(",");

    for (let numbersIndex of numberInArray) {
      numbers.push(+numbersIndex);

    }

    this.service.postSumSmallest({numbers})
      .subscribe(arg => this.result = arg.result);

  }
}
