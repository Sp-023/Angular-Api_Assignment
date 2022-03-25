import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule} from '@angular/common/http'
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http:HttpClient) {

   }
postTravels(data:any)
{
  return this.http.post<any>("https://localhost:44391/api/Travel",data)
  .pipe(map((res:any)=>
  {
    return res;
  }))
 
}
getTravels()
{
  return this.http.get<any>("https://localhost:44391/api/Travel")
  .pipe(map((res:any)=>{
  return res;
}))
}
updatetravels(data:any,id:number)
{
  return this.http.put<any>("https://localhost:44391/api/Travel"+data,id)
  .pipe(map((res:any)=>
  {
    return res;
  }))
}
deletetravels(id:number)
{
  return this.http.delete<any>("https://localhost:44391/api/Travel"+id)
  .pipe(map((res:any)=>
  {
    return res;
  }))
}
   
}



 