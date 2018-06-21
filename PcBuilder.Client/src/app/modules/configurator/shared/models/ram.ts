import { Product } from './product';

export class Ram extends Product {
  type: string;
  capacity: number;
  frequency: number;
  latency: string;
  standard: string;
  constructor() {
    super();
  }
}
