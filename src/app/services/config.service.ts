import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Sum } from '../models/sum';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {

  constructor(private http:HttpClient) { }

  postSumSmallest(numbers:Sum):Observable<any>{
    return this.http.post<any>("https://localhost:44374/api/sum",numbers);
  }
}
