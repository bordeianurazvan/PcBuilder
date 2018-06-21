export class Product {
  id: string;
  title: string;
  price: number;
  imageUrl: string;
  isSelected: boolean;
  url: string;
  constructor() {
    this.isSelected = false;
  }
}
