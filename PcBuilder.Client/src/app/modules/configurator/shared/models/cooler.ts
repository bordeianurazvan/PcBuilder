import { Product } from './product';

export class Cooler extends Product {
  type: string;
  heatPipes: number;
  height: number;
  fans: number;
  fanSize: number;
  fanSpeed: string;
  noise: string;
  compatibleSockets: string[];
  constructor() {
    super();
  }
}
