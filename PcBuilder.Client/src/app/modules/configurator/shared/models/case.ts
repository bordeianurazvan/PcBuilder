import { Product } from './product';

export class Case extends Product {
  type: string;
  numberOfSlots: number;
  coolerHeight: number;
  videoCardWidth: number;
  fans: number;
  totalFans: number;
  motherboardFormFactor: string[];
  constructor() {
    super();
  }
}
