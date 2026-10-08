using System.Collections.Generic;

namespace Ucu.Poo.PersonExporter
{
    /// <summary>
    /// Define la capacidad de exportar un reporte de personas a un archivo.
    /// </summary>
    public interface IExport
    {
        /// <summary>
        /// Genera el archivo del reporte.
        /// </summary>
        /// <param name="people">Lista de personas a incluir.</param>
        /// <param name="outputPath">Ruta del archivo de salida.</param>
        void Export(IList<Person> people, string outputPath);
    }
}
