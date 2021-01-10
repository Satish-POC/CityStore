import { Component, OnInit, Input, EventEmitter, Output, QueryList, Directive, ViewChildren } from '@angular/core';
import { Product } from '../interfaces/product'
import { PRODUCTS } from '../mocks/products-mock'
import { ProductService } from '../services/product.service';




@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products : Product[];
  selectedProduct: Product;
  selectedProductPanelTitle: string = "No Product Selected";
  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.getProducts();
  }

  onProductSelect(product: Product): void {
    this.selectedProduct = product;
    this.selectedProductPanelTitle = product.name + " selected.";
  }

  getProducts(): void{
    this.productService.getProducts()
      .subscribe(prods => this.products = prods); 
  } 
}
