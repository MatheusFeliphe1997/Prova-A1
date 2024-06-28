export interface Tarefa {
    idTarefa: string;
    nome: string;
    descricao: string;
    status: boolean;
    criadoEm?:string;
    categoriaId: string;
}