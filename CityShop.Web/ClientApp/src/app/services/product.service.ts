import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Product } from '../interfaces/product';
import { PRODUCTS } from '../mocks/products-mock';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private productsUrl = 'https://localhost:44347/api/products';
  //private productsUrl = 'api/products';

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'api-key': "API-QC0GBHVP3146DUG",
      'Access-Control-Allow-Origin': '*'
    })
  };

  constructor(private http: HttpClient) { }

  getProducts(): Observable<Product[]> {
    //return of(PRODUCTS);
    return this.http.get<Product[]>(this.productsUrl, this.httpOptions)
      .pipe(
        catchError(this.handleError<Product[]>('getProducts',[]))
      );
 
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

}
