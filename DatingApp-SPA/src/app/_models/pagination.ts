export interface Pagination {
    currentPage: number;
    itemsPerPage: number;
    totalItems: number;
    totelPages: number;
}

export class PaginatedResult<T> {
    result: T;
    pagination: Pagination;
}