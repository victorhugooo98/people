import { Component, OnInit, ViewChild, AfterViewInit, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTableModule, MatTable } from '@angular/material/table';
import { MatPaginatorModule, MatPaginator } from '@angular/material/paginator';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSortModule, MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { FormsModule } from '@angular/forms';
import { PessoaService } from '../../services/pessoa.service';
import { Pessoa } from '../../models/pessoa';

@Component({
  selector: 'app-pessoas-tabela',
  standalone: true,
  imports: [
    CommonModule,
    MatTableModule,
    MatPaginatorModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatSortModule,
    FormsModule
  ],
  templateUrl: './pessoas-tabela.component.html',
  styleUrl: './pessoas-tabela.component.css'
})
export class PessoasTabelaComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['cpf', 'nome', 'genero', 'idade', 'endereco', 'municipio', 'estado'];

  pessoas = signal<Pessoa[]>([]);

  dataSource = new MatTableDataSource<Pessoa>([]);

  filtroNome: string = '';

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private pessoaService: PessoaService) { }

  ngOnInit(): void {
    // Configurar a função de filtragem personalizada (opcional)
    this.dataSource.filterPredicate = (data: Pessoa, filter: string) => {
      return data.nome.toLowerCase().includes(filter);
    };
  }

  ngAfterViewInit(): void {
    // Conectar o paginador e o ordenador à fonte de dados
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  carregarDados(): void {
    this.pessoaService.getPessoas().subscribe({
      next: (dados) => {
        this.pessoas.set(dados);
        this.dataSource.data = dados;
      },
      error: (erro) => console.error('Erro ao carregar pessoas:', erro)
    });
  }

  aplicarFiltro(): void {
    this.dataSource.filter = this.filtroNome.trim().toLowerCase();

    if (this.paginator) {
      this.paginator.firstPage();
    }
  }
}
