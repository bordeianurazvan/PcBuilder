import { Product } from './product';

export class Storage extends Product {
  formFactor: string;
  interface: string;
  capacity: string;
  writeSpeed: string;
  readSpeed: string;
  rpm: string;
  constructor() {
      super();
  }
}
