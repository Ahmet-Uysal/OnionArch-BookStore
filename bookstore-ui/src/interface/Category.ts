export interface Category {
    name: string;
    parentId?: string;
    id: string;
    createdDate: Date;
    modifyDate: Date;
    isActive: boolean;
    isDeleted: boolean;
}
export interface CategoryState {
    data: Category[] | null;
    loading: boolean;
    error: string;
}
export interface Response<T> {
    isSuccess: boolean;
    data: T;
    message: string
}