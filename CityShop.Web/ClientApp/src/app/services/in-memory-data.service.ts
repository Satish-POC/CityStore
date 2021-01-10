import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Product } from '../interfaces/product';

@Injectable({
  providedIn: 'root'
})
export class InMemoryDataService implements InMemoryDbService {
  createDb() {
      const products = [
        { id: "1", name: "Product1", description: "Product1 description", price: 1999.99 },
        { id: "2", name: "Product2", description: "Product2 description", price: 2999.99 },
        { id: "3", name: "Product3", description: "Product3 description", price: 3999.99 },
        { id: "4", name: "Product4", description: "Product4 description", price: 4999.99 },
        { id: "5", name: "Product5", description: "Product5 description", price: 5999.99 },
        { id: "6", name: "Product6", description: "Product6 description", price: 6999.99 },
        { id: "7", name: "Product7", description: "Product7 description", price: 7999.99 },
        { id: "8", name: "Product8", description: "Product8 description", price: 8999.99 },
        { id: "9", name: "Product9", description: "Product9 description", price: 9999.99 },
        { id: "10", name: "Product10", description: "Product10 description", price: 10999.99 },
        { id: "11", name: "Product11", description: "Product11 description", price: 11999.99 },
        { id: "12", name: "Product12", description: "Product12 description", price: 12999.99 }
  ];
  return { products };
}
}
