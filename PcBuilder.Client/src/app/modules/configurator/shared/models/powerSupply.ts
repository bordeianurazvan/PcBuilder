import { Product } from './product';

export class PowerSupply extends Product {
  power: string;
  efficiency: string;
  certificate: string;
  cooler: string;
  pfc: string;
  isModular: boolean;
  constructor() {
      super();
  }
}
