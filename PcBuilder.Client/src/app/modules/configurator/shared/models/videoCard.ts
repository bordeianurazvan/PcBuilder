import { Product } from './product';

export class VideoCard extends Product {
  interface: string;
  resolution: string;
  type: string;
  memorySize: number;
  memoryBus: number;
  memoryFrequency: number;
  baseFrequency: number;
  gpuBoostClock: number;
  width: number;
  constructor() {
    super();
  }
}
