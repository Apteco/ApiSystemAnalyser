/* 
 * Apteco API
 *
 * An API to allow access to Apteco Marketing Suite resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Apteco.ApiSystemAnalyser.ApiClient.Client.SwaggerDateConverter;

namespace Apteco.ApiSystemAnalyser.ApiClient.Model
{
    /// <summary>
    /// Details for requesting some processing time statistics
    /// </summary>
    [DataContract]
    public partial class ProcessingTimeStatisticsDetails :  IEquatable<ProcessingTimeStatisticsDetails>
    {
        /// <summary>
        /// The type of processing time to measure
        /// </summary>
        /// <value>The type of processing time to measure</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MeasureEnum
        {
            
            /// <summary>
            /// Enum ProcessingTime for value: ProcessingTime
            /// </summary>
            [EnumMember(Value = "ProcessingTime")]
            ProcessingTime = 1,
            
            /// <summary>
            /// Enum QueueTime for value: QueueTime
            /// </summary>
            [EnumMember(Value = "QueueTime")]
            QueueTime = 2,
            
            /// <summary>
            /// Enum TotalTime for value: TotalTime
            /// </summary>
            [EnumMember(Value = "TotalTime")]
            TotalTime = 3
        }

        /// <summary>
        /// The type of processing time to measure
        /// </summary>
        /// <value>The type of processing time to measure</value>
        [DataMember(Name="measure", EmitDefaultValue=false)]
        public MeasureEnum Measure { get; set; }
        /// <summary>
        /// The type of thing to break down the jobs into - either a time period or other property such as job type
        /// </summary>
        /// <value>The type of thing to break down the jobs into - either a time period or other property such as job type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DimensionEnum
        {
            
            /// <summary>
            /// Enum Years for value: Years
            /// </summary>
            [EnumMember(Value = "Years")]
            Years = 1,
            
            /// <summary>
            /// Enum Quarters for value: Quarters
            /// </summary>
            [EnumMember(Value = "Quarters")]
            Quarters = 2,
            
            /// <summary>
            /// Enum Months for value: Months
            /// </summary>
            [EnumMember(Value = "Months")]
            Months = 3,
            
            /// <summary>
            /// Enum Weeks for value: Weeks
            /// </summary>
            [EnumMember(Value = "Weeks")]
            Weeks = 4,
            
            /// <summary>
            /// Enum Days for value: Days
            /// </summary>
            [EnumMember(Value = "Days")]
            Days = 5,
            
            /// <summary>
            /// Enum Hours for value: Hours
            /// </summary>
            [EnumMember(Value = "Hours")]
            Hours = 6,
            
            /// <summary>
            /// Enum Minutes for value: Minutes
            /// </summary>
            [EnumMember(Value = "Minutes")]
            Minutes = 7,
            
            /// <summary>
            /// Enum JobType for value: JobType
            /// </summary>
            [EnumMember(Value = "JobType")]
            JobType = 8,
            
            /// <summary>
            /// Enum Username for value: Username
            /// </summary>
            [EnumMember(Value = "Username")]
            Username = 9
        }

        /// <summary>
        /// The type of thing to break down the jobs into - either a time period or other property such as job type
        /// </summary>
        /// <value>The type of thing to break down the jobs into - either a time period or other property such as job type</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public DimensionEnum Dimension { get; set; }
        /// <summary>
        /// The property to use to select on the jobs to analyse
        /// </summary>
        /// <value>The property to use to select on the jobs to analyse</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JobPropertySelectionTypeEnum
        {
            
            /// <summary>
            /// Enum AllJobs for value: AllJobs
            /// </summary>
            [EnumMember(Value = "AllJobs")]
            AllJobs = 1,
            
            /// <summary>
            /// Enum Username for value: Username
            /// </summary>
            [EnumMember(Value = "Username")]
            Username = 2,
            
            /// <summary>
            /// Enum JobType for value: JobType
            /// </summary>
            [EnumMember(Value = "JobType")]
            JobType = 3
        }

        /// <summary>
        /// The property to use to select on the jobs to analyse
        /// </summary>
        /// <value>The property to use to select on the jobs to analyse</value>
        [DataMember(Name="jobPropertySelectionType", EmitDefaultValue=false)]
        public JobPropertySelectionTypeEnum JobPropertySelectionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingTimeStatisticsDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProcessingTimeStatisticsDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingTimeStatisticsDetails" /> class.
        /// </summary>
        /// <param name="Start">The start date and time of window of jobs to analyse (required).</param>
        /// <param name="End">The end date and time of window of jobs to analyse (required).</param>
        /// <param name="Measure">The type of processing time to measure (required).</param>
        /// <param name="Dimension">The type of thing to break down the jobs into - either a time period or other property such as job type (required).</param>
        /// <param name="JobPropertySelectionType">The property to use to select on the jobs to analyse (required).</param>
        /// <param name="JobPropertySelections">The set of property values to use to select the jobs (required).</param>
        public ProcessingTimeStatisticsDetails(DateTime? Start = default(DateTime?), DateTime? End = default(DateTime?), MeasureEnum Measure = default(MeasureEnum), DimensionEnum Dimension = default(DimensionEnum), JobPropertySelectionTypeEnum JobPropertySelectionType = default(JobPropertySelectionTypeEnum), List<string> JobPropertySelections = default(List<string>))
        {
            // to ensure "Start" is required (not null)
            if (Start == null)
            {
                throw new InvalidDataException("Start is a required property for ProcessingTimeStatisticsDetails and cannot be null");
            }
            else
            {
                this.Start = Start;
            }
            // to ensure "End" is required (not null)
            if (End == null)
            {
                throw new InvalidDataException("End is a required property for ProcessingTimeStatisticsDetails and cannot be null");
            }
            else
            {
                this.End = End;
            }
            // to ensure "Measure" is required (not null)
            if (Measure == null)
            {
                throw new InvalidDataException("Measure is a required property for ProcessingTimeStatisticsDetails and cannot be null");
            }
            else
            {
                this.Measure = Measure;
            }
            // to ensure "Dimension" is required (not null)
            if (Dimension == null)
            {
                throw new InvalidDataException("Dimension is a required property for ProcessingTimeStatisticsDetails and cannot be null");
            }
            else
            {
                this.Dimension = Dimension;
            }
            // to ensure "JobPropertySelectionType" is required (not null)
            if (JobPropertySelectionType == null)
            {
                throw new InvalidDataException("JobPropertySelectionType is a required property for ProcessingTimeStatisticsDetails and cannot be null");
            }
            else
            {
                this.JobPropertySelectionType = JobPropertySelectionType;
            }
            // to ensure "JobPropertySelections" is required (not null)
            if (JobPropertySelections == null)
            {
                throw new InvalidDataException("JobPropertySelections is a required property for ProcessingTimeStatisticsDetails and cannot be null");
            }
            else
            {
                this.JobPropertySelections = JobPropertySelections;
            }
        }
        
        /// <summary>
        /// The start date and time of window of jobs to analyse
        /// </summary>
        /// <value>The start date and time of window of jobs to analyse</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }

        /// <summary>
        /// The end date and time of window of jobs to analyse
        /// </summary>
        /// <value>The end date and time of window of jobs to analyse</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public DateTime? End { get; set; }




        /// <summary>
        /// The set of property values to use to select the jobs
        /// </summary>
        /// <value>The set of property values to use to select the jobs</value>
        [DataMember(Name="jobPropertySelections", EmitDefaultValue=false)]
        public List<string> JobPropertySelections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessingTimeStatisticsDetails {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Measure: ").Append(Measure).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  JobPropertySelectionType: ").Append(JobPropertySelectionType).Append("\n");
            sb.Append("  JobPropertySelections: ").Append(JobPropertySelections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProcessingTimeStatisticsDetails);
        }

        /// <summary>
        /// Returns true if ProcessingTimeStatisticsDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessingTimeStatisticsDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessingTimeStatisticsDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Measure == input.Measure ||
                    (this.Measure != null &&
                    this.Measure.Equals(input.Measure))
                ) && 
                (
                    this.Dimension == input.Dimension ||
                    (this.Dimension != null &&
                    this.Dimension.Equals(input.Dimension))
                ) && 
                (
                    this.JobPropertySelectionType == input.JobPropertySelectionType ||
                    (this.JobPropertySelectionType != null &&
                    this.JobPropertySelectionType.Equals(input.JobPropertySelectionType))
                ) && 
                (
                    this.JobPropertySelections == input.JobPropertySelections ||
                    this.JobPropertySelections != null &&
                    this.JobPropertySelections.SequenceEqual(input.JobPropertySelections)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Measure != null)
                    hashCode = hashCode * 59 + this.Measure.GetHashCode();
                if (this.Dimension != null)
                    hashCode = hashCode * 59 + this.Dimension.GetHashCode();
                if (this.JobPropertySelectionType != null)
                    hashCode = hashCode * 59 + this.JobPropertySelectionType.GetHashCode();
                if (this.JobPropertySelections != null)
                    hashCode = hashCode * 59 + this.JobPropertySelections.GetHashCode();
                return hashCode;
            }
        }
    }

}
