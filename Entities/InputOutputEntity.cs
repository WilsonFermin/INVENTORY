using System;
using System.ComponentModel.DataAnnotations;

public class InputOutputEntity
{
    [Key]
    [StringLength(50)]
    public string InOutId { get; set; }

    [Required]
    public DateTime InOutDate { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public bool IsInput { get; set; }

    //Relacion con almacenamientos(StorageEntity)
    public string StorageId {get; set;}  
    public StorageEntity Storage {get; set;}
}