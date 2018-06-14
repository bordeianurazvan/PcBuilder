import { Product } from './product';

export class Motherboard extends Product {
  formFactor: string;
  socket: string;
  sata: number;
  m2: number;
  network: string;
  typeOfRam: string;
  maximumRamMemory: number;
  ramFrequncy: number;
  ramSlots: number;
  graphicInterface: string;
}
