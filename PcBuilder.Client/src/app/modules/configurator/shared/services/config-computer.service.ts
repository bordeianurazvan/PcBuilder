import { Injectable } from '@angular/core';
import { Computer } from '../models/Computer';
import { environment } from '../../../../../environments/environment';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Case } from '../models/case';
import { Cpu } from '../models/cpu';
import { Cooler } from '../models/cooler';
import { Motherboard } from '../models/motherboard';
import { Ram } from '../models/ram';
import { VideoCard } from '../models/videoCard';
import { PowerSupply } from '../models/powerSupply';

@Injectable()
export class ConfigComputerService {
  public computer: Computer;
  public price: number;
  public progress: number;
  public baseUrl: string;

  constructor(private http: HttpClient) {
    this.computer = new Computer();
    this.price = 0;
    this.progress = 1;
    this.baseUrl = environment.apiUrl;
  }

  public get cases() {
    const baseUrl = this.baseUrl;
    return {
      getById: (id: string) => {
        const url = `${baseUrl}/api/cases/${id}`;
        return this.http.get<Case>(url);
      },
      getAll: (filter: string) => {
        const url = `${baseUrl}/api/cases`;
        let params = new HttpParams();
        params = params.append('filterObject', filter);
        return this.http.get<Case[]>(url, { params: params });
      }
    };
  }

  public get cpus() {
    const baseUrl = this.baseUrl;
    return {
      getById: (id: string) => {
        const url = `${baseUrl}/api/cpus/${id}`;
        return this.http.get<Cpu>(url);
      },
      getAll: (filter: string) => {
        const url = `${baseUrl}/api/cpus`;
        let params = new HttpParams();
        params = params.append('filterObject', filter);
        return this.http.get<Cpu[]>(url, { params: params });
      }
    };
  }

  public get coolers() {
    const baseUrl = this.baseUrl;
    return {
      getById: (id: string) => {
        const url = `${baseUrl}/api/coolers/${id}`;
        return this.http.get<Cooler>(url);
      },
      getAll: (filter: string) => {
        const url = `${baseUrl}/api/coolers`;
        let params = new HttpParams();
        params = params.append('filterObject', filter);
        return this.http.get<Cooler[]>(url, { params: params });
      }
    };
  }

  public get motherboards() {
    const baseUrl = this.baseUrl;
    return {
      getById: (id: string) => {
        const url = `${baseUrl}/api/motherboards/${id}`;
        return this.http.get<Motherboard>(url);
      },
      getAll: (filter: string) => {
        const url = `${baseUrl}/api/motherboards`;
        let params = new HttpParams();
        params = params.append('filterObject', filter);
        return this.http.get<Motherboard[]>(url, { params: params });
      }
    };
  }

  public get rams() {
    const baseUrl = this.baseUrl;
    return {
      getById: (id: string) => {
        const url = `${baseUrl}/api/rams/${id}`;
        return this.http.get<Ram>(url);
      },
      getAll: (filter: string) => {
        const url = `${baseUrl}/api/rams`;
        let params = new HttpParams();
        params = params.append('filterObject', filter);
        return this.http.get<Ram[]>(url, { params: params });
      }
    };
  }

  public get videocards() {
    const baseUrl = this.baseUrl;
    return {
      getById: (id: string) => {
        const url = `${baseUrl}/api/videocards/${id}`;
        return this.http.get<VideoCard>(url);
      },
      getAll: (filter: string) => {
        const url = `${baseUrl}/api/videocards`;
        let params = new HttpParams();
        params = params.append('filterObject', filter);
        return this.http.get<VideoCard[]>(url, { params: params });
      }
    };
  }

  public get storages() {
    const baseUrl = this.baseUrl;
    return {
      getById: (id: string) => {
        const url = `${baseUrl}/api/storages/${id}`;
        return this.http.get<Storage>(url);
      },
      getAll: (filter: string) => {
        const url = `${baseUrl}/api/storages`;
        let params = new HttpParams();
        params = params.append('filterObject', filter);
        return this.http.get<Storage[]>(url, { params: params });
      }
    };
  }

  public get powersupplies() {
    const baseUrl = this.baseUrl;
    return {
      getById: (id: string) => {
        const url = `${baseUrl}/api/powersupplies/${id}`;
        return this.http.get<PowerSupply>(url);
      },
      getAll: (filter: string) => {
        const url = `${baseUrl}/api/powersupplies`;
        let params = new HttpParams();
        params = params.append('filterObject', filter);
        return this.http.get<PowerSupply[]>(url, { params: params });
      }
    };
  }
}
