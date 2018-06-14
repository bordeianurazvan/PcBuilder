import { Product } from './product';

export class Cpu extends Product {
  socket: string;
  series: string;
  core: string;
  cores: number;
  threads: number;
  baseFrequency: number;
  turboFrequency: number;
  cache: number;
  hasStockCooler: boolean;
  typeOfRam: string;
  maximumRamMemory: number;
  ramFrequency: number;
  constructor() {
    super();
  }
}
